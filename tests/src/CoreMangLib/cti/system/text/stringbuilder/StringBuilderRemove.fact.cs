using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderRemove_StringBuilderRemove_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderRemove_StringBuilderRemove_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderRemove\\StringBuilderRemove.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
