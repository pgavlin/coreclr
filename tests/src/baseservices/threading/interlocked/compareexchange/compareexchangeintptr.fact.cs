using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_compareexchangeintptr_compareexchangeintptr_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangeintptr_compareexchangeintptr_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangeintptr\\compareexchangeintptr.cmd");
        }
    }
}
