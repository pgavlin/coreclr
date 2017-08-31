using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_unicodeencoding_UnicodeEncodingGetHashCode_UnicodeEncodingGetHashCode_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_unicodeencoding_UnicodeEncodingGetHashCode_UnicodeEncodingGetHashCode_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\unicodeencoding\\UnicodeEncodingGetHashCode\\UnicodeEncodingGetHashCode.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
