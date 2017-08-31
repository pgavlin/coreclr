using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertFromBase64CharArray_ConvertFromBase64CharArray_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertFromBase64CharArray_ConvertFromBase64CharArray_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertFromBase64CharArray\\ConvertFromBase64CharArray.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
