using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertChangeType2_ConvertChangeType2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertChangeType2_ConvertChangeType2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertChangeType2\\ConvertChangeType2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
