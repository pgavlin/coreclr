using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_textwriter_TextWriterNull_PSC_TextWriterNull_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_textwriter_TextWriterNull_PSC_TextWriterNull_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\textwriter\\TextWriterNull_PSC\\TextWriterNull_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
