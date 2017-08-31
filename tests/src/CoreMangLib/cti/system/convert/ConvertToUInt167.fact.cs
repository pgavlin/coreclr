using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt167_ConvertToUInt167_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt167_ConvertToUInt167_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt167\\ConvertToUInt167.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
