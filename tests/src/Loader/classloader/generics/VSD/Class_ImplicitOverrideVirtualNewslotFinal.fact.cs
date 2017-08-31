using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class_ImplicitOverrideVirtualNewslotFinal_Class_ImplicitOverrideVirtualNewslotFinal_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class_ImplicitOverrideVirtualNewslotFinal_Class_ImplicitOverrideVirtualNewslotFinal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class_ImplicitOverrideVirtualNewslotFinal\\Class_ImplicitOverrideVirtualNewslotFinal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
