using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToDouble12_ConvertToDouble12_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToDouble12_ConvertToDouble12_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToDouble12\\ConvertToDouble12.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
