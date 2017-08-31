using CoreclrTestLib;
using Xunit;

namespace Loader_versioning
{
    class _coverage_AssemblyAttrs_AssemblyAttrs_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_AssemblyAttrs_AssemblyAttrs_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("Loader\\versioning\\coverage\\AssemblyAttrs\\AssemblyAttrs.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
