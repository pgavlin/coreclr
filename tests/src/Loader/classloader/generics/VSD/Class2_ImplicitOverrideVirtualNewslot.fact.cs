using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class2_ImplicitOverrideVirtualNewslot_Class2_ImplicitOverrideVirtualNewslot_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class2_ImplicitOverrideVirtualNewslot_Class2_ImplicitOverrideVirtualNewslot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class2_ImplicitOverrideVirtualNewslot\\Class2_ImplicitOverrideVirtualNewslot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
