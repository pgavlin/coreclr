using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderAppend16_StringBuilderAppend16_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderAppend16_StringBuilderAppend16_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderAppend16\\StringBuilderAppend16.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
