using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_io_fileattributes_FileAttributesSystem_FileAttributesSystem_
    {
        [OuterLoop]
        [Fact]
        public void _system_io_fileattributes_FileAttributesSystem_FileAttributesSystem_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\io\\fileattributes\\FileAttributesSystem\\FileAttributesSystem.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
