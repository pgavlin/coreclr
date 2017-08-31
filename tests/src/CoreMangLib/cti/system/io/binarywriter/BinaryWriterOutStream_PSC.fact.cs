using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_binarywriter_BinaryWriterOutStream_PSC_BinaryWriterOutStream_PSC_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_binarywriter_BinaryWriterOutStream_PSC_BinaryWriterOutStream_PSC_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\binarywriter\\BinaryWriterOutStream_PSC\\BinaryWriterOutStream_PSC.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
