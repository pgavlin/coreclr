using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesReparsePoint_FileAttributesReparsePoint_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesReparsePoint_FileAttributesReparsePoint_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesReparsePoint\\FileAttributesReparsePoint.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
