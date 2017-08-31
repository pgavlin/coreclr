using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_calli2_calli2_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_calli2_calli2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\calli2\\calli2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
