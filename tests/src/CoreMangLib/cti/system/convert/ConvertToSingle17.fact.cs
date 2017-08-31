using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToSingle17_ConvertToSingle17_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToSingle17_ConvertToSingle17_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToSingle17\\ConvertToSingle17.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
