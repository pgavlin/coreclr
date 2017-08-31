using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_ldvirtftn_ldvirtftn_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_ldvirtftn_ldvirtftn_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\ldvirtftn\\ldvirtftn.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
