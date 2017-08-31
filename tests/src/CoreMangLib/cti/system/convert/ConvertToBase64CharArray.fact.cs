using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertToBase64CharArray_ConvertToBase64CharArray_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertToBase64CharArray_ConvertToBase64CharArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertToBase64CharArray\\ConvertToBase64CharArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
