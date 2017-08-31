using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesCompressed_FileAttributesCompressed_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesCompressed_FileAttributesCompressed_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesCompressed\\FileAttributesCompressed.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
