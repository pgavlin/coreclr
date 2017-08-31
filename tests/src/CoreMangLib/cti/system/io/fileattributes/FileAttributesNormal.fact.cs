using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesNormal_FileAttributesNormal_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesNormal_FileAttributesNormal_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesNormal\\FileAttributesNormal.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
