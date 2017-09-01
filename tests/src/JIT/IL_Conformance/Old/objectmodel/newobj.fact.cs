using CoreclrTestLib;
using Xunit;

namespace JIT_IL_Conformance
{
    public class _Old_objectmodel_newobj_newobj_
    {
        [OuterLoop]
        [Fact]
        public void _Old_objectmodel_newobj_newobj_cmd()
        {
            CoreclrTestWrapperLib.RunTest("JIT\\IL_Conformance\\Old\\objectmodel\\newobj\\newobj.cmd");
        }
    }
}
