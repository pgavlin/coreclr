using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_string_StringCtorChar_StringCtorChar_
    {
        [OuterLoop]
        [Fact]
        public void _system_string_StringCtorChar_StringCtorChar_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\string\\StringCtorChar\\StringCtorChar.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
