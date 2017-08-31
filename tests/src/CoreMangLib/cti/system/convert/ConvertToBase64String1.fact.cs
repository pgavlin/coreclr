using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBase64String1_ConvertToBase64String1_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBase64String1_ConvertToBase64String1_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBase64String1\\ConvertToBase64String1.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
