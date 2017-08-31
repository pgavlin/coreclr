using CoreclrTestLib;
using Xunit;

namespace Loader_binding
{
    class _assemblies_generics_arilistienum_methods_exceptions_exceptions_
    {
        [OuterLoop]
        [Fact]
        public void _assemblies_generics_arilistienum_methods_exceptions_exceptions_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\binding\\assemblies\\generics\\arilistienum\\methods\\exceptions\\exceptions.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
