using CoreclrTestLib;
using Xunit;

namespace baseservices_threading
{
    public class _interlocked_compareexchange_compareexchangeobject_compareexchangeobject_
    {
        [OuterLoop]
        [Fact]
        public void _interlocked_compareexchange_compareexchangeobject_compareexchangeobject_cmd()
        {
            CoreclrTestWrapperLib.RunTest("baseservices\\threading\\interlocked\\compareexchange\\compareexchangeobject\\compareexchangeobject.cmd");
        }
    }
}
