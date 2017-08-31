using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Struct_ImplicitOverrideVirtualNewslot_Struct_ImplicitOverrideVirtualNewslot_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Struct_ImplicitOverrideVirtualNewslot_Struct_ImplicitOverrideVirtualNewslot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Struct_ImplicitOverrideVirtualNewslot\\Struct_ImplicitOverrideVirtualNewslot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
