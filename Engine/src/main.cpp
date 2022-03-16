#include <windows.h>
#include <vcclr.h>
#include <memory>
#include <iostream>
#using <System.dll>

namespace example {

	class UnmanagedClass {
	public:
		LPCWSTR GetPropertyA() { return 0; }
		void MethodB(LPCWSTR) {
			std::cout << "welcome to the jungle!\n";
		}
	};

	public ref class ManagedClass {
	public:
		// Allocate the native object on the C++ Heap via a constructor
		ManagedClass() : m_Impl(new UnmanagedClass) {
			std::cout << "impl created!\n";
		}

		// Deallocate the native object on a destructor
		~ManagedClass() {
			delete m_Impl;
			std::cout << "impl deleated!\n";
		}

	protected:
		// Deallocate the native object on the finalizer just in case no destructor is called
		!ManagedClass() {
			delete m_Impl;
			std::cout << "impl finalizer called!\n";
		}

	public:
		property System::String^ get_PropertyA {
			System::String^ get() {
		//		return gcnew System::String(m_Impl->GetPropertyA());
				return gcnew System::String("property A");
			}
		}

		void MethodB(System::String^ theString) {
			pin_ptr<const WCHAR> str = PtrToStringChars(theString);
			m_Impl->MethodB(str);
		}

	private:
		UnmanagedClass* m_Impl;
	};

}