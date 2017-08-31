using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_convert_ConvertFromBase64String_ConvertFromBase64String_
    {
        [OuterLoop]
        [Fact]
        public void _system_convert_ConvertFromBase64String_ConvertFromBase64String_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\convert\\ConvertFromBase64String\\ConvertFromBase64String.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
