using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class_ImplicitOverrideVirtualNewslot_Class_ImplicitOverrideVirtualNewslot_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class_ImplicitOverrideVirtualNewslot_Class_ImplicitOverrideVirtualNewslot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class_ImplicitOverrideVirtualNewslot\\Class_ImplicitOverrideVirtualNewslot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
