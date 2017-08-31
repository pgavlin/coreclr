using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_unicodeencoding_UnicodeEncodingEquals_UnicodeEncodingEquals_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_unicodeencoding_UnicodeEncodingEquals_UnicodeEncodingEquals_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\unicodeencoding\\UnicodeEncodingEquals\\UnicodeEncodingEquals.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
