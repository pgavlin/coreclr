using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesDirectory_FileAttributesDirectory_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesDirectory_FileAttributesDirectory_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesDirectory\\FileAttributesDirectory.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
