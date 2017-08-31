using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class2_ImplicitOverrideVirtual_Interface_Class2_ImplicitOverrideVirtual_Interface_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class2_ImplicitOverrideVirtual_Interface_Class2_ImplicitOverrideVirtual_Interface_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class2_ImplicitOverrideVirtual_Interface\\Class2_ImplicitOverrideVirtual_Interface.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
