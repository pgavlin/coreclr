using CoreclrTestLib;
using Xunit;

namespace JIT_Directed
{
    class _coverage_importer_byrefsubbyref1_byrefsubbyref1_
    {
        [OuterLoop]
        [Fact]
        public void _coverage_importer_byrefsubbyref1_byrefsubbyref1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Directed\\coverage\\importer\\byrefsubbyref1\\byrefsubbyref1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
