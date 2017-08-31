using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class_ExplicitOverrideVirtualNewslotFinal_Class_ExplicitOverrideVirtualNewslotFinal_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class_ExplicitOverrideVirtualNewslotFinal_Class_ExplicitOverrideVirtualNewslotFinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class_ExplicitOverrideVirtualNewslotFinal\\Class_ExplicitOverrideVirtualNewslotFinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
