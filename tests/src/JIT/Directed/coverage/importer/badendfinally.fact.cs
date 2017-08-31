using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_badendfinally_badendfinally_
    {
        [Fact]
        public void _coverage_importer_badendfinally_badendfinally_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\badendfinally\\badendfinally.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
