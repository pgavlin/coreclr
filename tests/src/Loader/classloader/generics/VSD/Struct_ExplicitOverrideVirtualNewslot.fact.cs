using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Struct_ExplicitOverrideVirtualNewslot_Struct_ExplicitOverrideVirtualNewslot_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Struct_ExplicitOverrideVirtualNewslot_Struct_ExplicitOverrideVirtualNewslot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Struct_ExplicitOverrideVirtualNewslot\\Struct_ExplicitOverrideVirtualNewslot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
