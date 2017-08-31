using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Struct_ExplicitOverrideVirtualNewslotFinal_Struct_ExplicitOverrideVirtualNewslotFinal_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Struct_ExplicitOverrideVirtualNewslotFinal_Struct_ExplicitOverrideVirtualNewslotFinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Struct_ExplicitOverrideVirtualNewslotFinal\\Struct_ExplicitOverrideVirtualNewslotFinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
