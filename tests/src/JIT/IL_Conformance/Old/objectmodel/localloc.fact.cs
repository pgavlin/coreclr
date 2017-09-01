using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_localloc_localloc_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_localloc_localloc_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\localloc\\localloc.cmd");
        }
    }
}
