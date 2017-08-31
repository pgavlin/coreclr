using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Struct_ImplicitOverrideVirtualNewslotFinal_Struct_ImplicitOverrideVirtualNewslotFinal_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Struct_ImplicitOverrideVirtualNewslotFinal_Struct_ImplicitOverrideVirtualNewslotFinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Struct_ImplicitOverrideVirtualNewslotFinal\\Struct_ImplicitOverrideVirtualNewslotFinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
