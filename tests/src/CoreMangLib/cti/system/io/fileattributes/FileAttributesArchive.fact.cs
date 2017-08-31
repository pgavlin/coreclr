using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesArchive_FileAttributesArchive_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesArchive_FileAttributesArchive_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesArchive\\FileAttributesArchive.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
