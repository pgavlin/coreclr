using CoreclrTestLib;
using Xunit;

namespace Loader_classloader
{
    class _generics_VSD_Class2_ImplicitOverrideVirtual_Class2_ImplicitOverrideVirtual_
    {
        [OuterLoop]
        [Fact]
        public void _generics_VSD_Class2_ImplicitOverrideVirtual_Class2_ImplicitOverrideVirtual_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\classloader\\generics\\VSD\\Class2_ImplicitOverrideVirtual\\Class2_ImplicitOverrideVirtual.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
