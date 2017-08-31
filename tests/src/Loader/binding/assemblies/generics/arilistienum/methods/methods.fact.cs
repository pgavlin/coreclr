using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_generics_arilistienum_methods_methods_methods_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_generics_arilistienum_methods_methods_methods_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\generics\\arilistienum\\methods\\methods\\methods.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
