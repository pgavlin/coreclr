using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_random_RandomNext3_RandomNext3_
    {
        [OuterLoop]
        [Fact]
        public void _system_random_RandomNext3_RandomNext3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\random\\RandomNext3\\RandomNext3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
