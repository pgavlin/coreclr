using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt644_ConvertToUInt644_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt644_ConvertToUInt644_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt644\\ConvertToUInt644.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
