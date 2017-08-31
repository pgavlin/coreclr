using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderReplace4_StringBuilderReplace4_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderReplace4_StringBuilderReplace4_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderReplace4\\StringBuilderReplace4.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
