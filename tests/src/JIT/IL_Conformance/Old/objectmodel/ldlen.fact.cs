using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_ldlen_ldlen_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldlen_ldlen_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldlen\\ldlen.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
