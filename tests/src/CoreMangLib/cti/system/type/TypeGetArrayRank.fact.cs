using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_type_TypeGetArrayRank_TypeGetArrayRank_
    {
        [OuterLoop]
        [Fact]
        public void _system_type_TypeGetArrayRank_TypeGetArrayRank_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\type\\TypeGetArrayRank\\TypeGetArrayRank.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
