using CoreclrTestLib;
using Xunit;

namespace CoreMangLib_cti
{
    class _system_text_stringbuilder_StringBuilderctor3_StringBuilderctor3_
    {
        [OuterLoop]
        [Fact]
        public void _system_text_stringbuilder_StringBuilderctor3_StringBuilderctor3_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("CoreMangLib\\cti\\system\\text\\stringbuilder\\StringBuilderctor3\\StringBuilderctor3.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
