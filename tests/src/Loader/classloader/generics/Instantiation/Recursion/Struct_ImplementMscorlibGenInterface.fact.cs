using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_Instantiation_Recursion_Struct_ImplementMscorlibGenInterface_Struct_ImplementMscorlibGenInterface_
    {
        [OuterLoop]
        [Fact]
        public void _generics_Instantiation_Recursion_Struct_ImplementMscorlibGenInterface_Struct_ImplementMscorlibGenInterface_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\Instantiation\\Recursion\\Struct_ImplementMscorlibGenInterface\\Struct_ImplementMscorlibGenInterface.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
