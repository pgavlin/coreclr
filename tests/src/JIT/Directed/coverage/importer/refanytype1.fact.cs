using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_refanytype1_refanytype1_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_refanytype1_refanytype1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\refanytype1\\refanytype1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
