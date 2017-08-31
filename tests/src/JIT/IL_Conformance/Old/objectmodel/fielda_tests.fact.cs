using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_fielda_tests_fielda_tests_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_fielda_tests_fielda_tests_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\fielda_tests\\fielda_tests.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
