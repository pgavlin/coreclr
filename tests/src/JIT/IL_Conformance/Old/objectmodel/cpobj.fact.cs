using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    class _Old_objectmodel_cpobj_cpobj_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_cpobj_cpobj_cmd()
        {
            int rv = CoreClrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\cpobj\\cpobj.cmd");
            Assert.Equal(rv, CoreClrTestWrapperLib.EXIT_SUCCESS_CODE);
        }
    }
}
