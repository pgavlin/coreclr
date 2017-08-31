using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_stringwriter_StringWriterEncoding_PSC_StringWriterEncoding_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_stringwriter_StringWriterEncoding_PSC_StringWriterEncoding_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\stringwriter\\StringWriterEncoding_PSC\\StringWriterEncoding_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
