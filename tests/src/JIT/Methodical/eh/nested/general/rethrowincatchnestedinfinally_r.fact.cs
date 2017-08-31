using CoreclrTestLib;
using Xunit;

namespace JIT_Methodical
{
    class _eh_nested_general_rethrowincatchnestedinfinally_r_rethrowincatchnestedinfinally_r_
    {
        [Fact]
        public void _eh_nested_general_rethrowincatchnestedinfinally_r_rethrowincatchnestedinfinally_r_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\Methodical\\eh\\nested\\general\\rethrowincatchnestedinfinally_r\\rethrowincatchnestedinfinally_r.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
