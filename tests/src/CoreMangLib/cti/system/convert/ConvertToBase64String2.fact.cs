using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBase64String2_ConvertToBase64String2_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBase64String2_ConvertToBase64String2_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBase64String2\\ConvertToBase64String2.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
