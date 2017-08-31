using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToUInt649_ConvertToUInt649_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToUInt649_ConvertToUInt649_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToUInt649\\ConvertToUInt649.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
