using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringIndexOf10_StringIndexOf10_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringIndexOf10_StringIndexOf10_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringIndexOf10\\StringIndexOf10.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
