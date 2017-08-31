using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _PrivateInterfaceImpl_Test6_ImplementingClass_Test6_ImplementingClass_
    {
        [OuterLoop]
        [Fact]
        public void _PrivateInterfaceImpl_Test6_ImplementingClass_Test6_ImplementingClass_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\PrivateInterfaceImpl\\Test6_ImplementingClass\\Test6_ImplementingClass.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
