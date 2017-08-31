using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class_ExplicitOverrideVirtualNewslot_Class_ExplicitOverrideVirtualNewslot_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class_ExplicitOverrideVirtualNewslot_Class_ExplicitOverrideVirtualNewslot_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class_ExplicitOverrideVirtualNewslot\\Class_ExplicitOverrideVirtualNewslot.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
