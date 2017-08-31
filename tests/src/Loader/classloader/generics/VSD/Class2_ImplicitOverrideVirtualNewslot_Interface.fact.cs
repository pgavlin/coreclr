using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class2_ImplicitOverrideVirtualNewslot_Interface_Class2_ImplicitOverrideVirtualNewslot_Interface_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class2_ImplicitOverrideVirtualNewslot_Interface_Class2_ImplicitOverrideVirtualNewslot_Interface_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class2_ImplicitOverrideVirtualNewslot_Interface\\Class2_ImplicitOverrideVirtualNewslot_Interface.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
